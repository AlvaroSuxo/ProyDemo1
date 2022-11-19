using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyDemo1.Data.Entity;
using ProyDemo1.Data.Helper;
using ProyDemo1.Data.Repository;

namespace ProyDemo1.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly IUserHelper userHelper;

        public ProductController(IProductRepository productRepository,IUserHelper userHelper)
        {
            this.productRepository = productRepository;
            this.userHelper = userHelper;
        }
        public IActionResult Index()
        {
            return View(this.productRepository .GetAll());
        }
        public IActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var product = this.repository.GetProduct(Id.Value);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {

                this.repository.AddProduct(product);
                await this.repository.SaveAllAsing();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        public IActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var product = this.repository.GetProduct(Id.Value);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    //TODO: pendiente el cambio de: This

                    this.repository.UpdateProduct(product);
                    await this.repository.SaveAllAsing();
                    return RedirectToAction(nameof(Index));

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (this.repository.ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);

        }
        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var product = this.productRepository.GetByIdAsync(Id.Value);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int Id)
        {
            var product = await this.productRepository.GetByIdAsync(Id);
            await this.productRepository.DeleteAsync(Id);
            return RedirectToAction(nameof(Index));
        }
    }
}