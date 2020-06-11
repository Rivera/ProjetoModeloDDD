using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Application.Model;
using ProjetoModeloDDD.Application.Transformation;
using System.Web.Mvc;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IProdutoAppService _produtoApp;
        private readonly IClienteAppService _clienteApp;

        public ProdutosController(IProdutoAppService produtoApp, IClienteAppService clienteApp)
        {
            _produtoApp = produtoApp;
            _clienteApp = clienteApp;
        }

        // GET: Produtos
        public ActionResult Index()
        {
            var ProdutosModel = new ProdutoTransformation().TransformarProdutoEmProdutoModel(_produtoApp.GetAll());
            return View(ProdutosModel);
        }

        // GET: Produtos/Details/5
        public ActionResult Details(int id)
        {
            var produto = _produtoApp.GetById(id);
            var ProdutoModel = new ProdutoTransformation().TransformarProdutoEmProdutoModel(produto);
            return View(ProdutoModel);
        }

        // GET: Produtos/Create
        public ActionResult Create()
        {
            ViewBag.clienteId = new SelectList(_clienteApp.GetAll(), "ClienteId", "Nome");
            return View();
        }

        // POST: Produtos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoModel produtoModel)
        {
            if (ModelState.IsValid)
            {
                var produto = new ProdutoTransformation().TransformarProdutoModelEmProduto(produtoModel);
                _produtoApp.Add(produto);

                return RedirectToAction("Index");
            }

            ViewBag.clienteId = new SelectList(_clienteApp.GetAll(), "ClienteId", "Nome", produtoModel.ClienteId);

            return View(produtoModel);
        }

        // GET: Produtos/Edit/5
        public ActionResult Edit(int id)
        {
            var produto = _produtoApp.GetById(id);
            var produtoModel = new ProdutoTransformation().TransformarProdutoEmProdutoModel(produto);
            return View(produtoModel);
        }

        // POST: Produtos/Edit/5
        [HttpPost]
        public ActionResult Edit(ProdutoModel produtoModel)
        {
            if (ModelState.IsValid)
            {
                var produto = new ProdutoTransformation().TransformarProdutoModelEmProduto(produtoModel);
                _produtoApp.Update(produto);

                return RedirectToAction("Index");
            }

            return View(produtoModel);
        }

        // GET: Produtos/Delete/5
        public ActionResult Delete(int id)
        {
            var produto = _produtoApp.GetById(id);
            var produtoModel = new ProdutoTransformation().TransformarProdutoEmProdutoModel(produto);

            return View(produtoModel);
        }

        // POST: Produtos/Delete/5
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            var produto = _produtoApp.GetById(id);
            _produtoApp.Remove(produto);

            return RedirectToAction("Index");
        }
    }
}