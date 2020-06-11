using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Application.Model;
using ProjetoModeloDDD.Application.Transformation;
using System.Web.Mvc;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteAppService _clienteApp;

        public ClientesController(IClienteAppService clienteApp)
        {
            _clienteApp = clienteApp;
        }

        // GET: Clientes
        public ActionResult Index()
        {
            var clientesModel = new ClienteTransformation().TransformarClienteEmClienteModel(_clienteApp.GetAll());
            return View(clientesModel);
        }

        public ActionResult Especiais()
        {
            var clientesModel = new ClienteTransformation().TransformarClienteEmClienteModel(_clienteApp.ObterClientesEspecias());
            return View(clientesModel);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            var cliente = _clienteApp.GetById(id);
            var clienteModel = new ClienteTransformation().TransformarClienteEmClienteModel(cliente);
            return View(clienteModel);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteModel clienteModel)
        {
            if (ModelState.IsValid)
            {
                var cliente = new ClienteTransformation().TransformarClienteModelEmCliente(clienteModel);
                _clienteApp.Add(cliente);

                return RedirectToAction("Index");
            }

            return View(clienteModel);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            var cliente = _clienteApp.GetById(id);
            var clienteModel = new ClienteTransformation().TransformarClienteEmClienteModel(cliente);
            return View(clienteModel);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(ClienteModel clienteModel)
        {
            if (ModelState.IsValid)
            {
                var cliente = new ClienteTransformation().TransformarClienteModelEmCliente(clienteModel);
                _clienteApp.Update(cliente);

                return RedirectToAction("Index");
            }

            return View(clienteModel);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            var cliente = _clienteApp.GetById(id);
            var clienteModel = new ClienteTransformation().TransformarClienteEmClienteModel(cliente);

            return View(clienteModel);
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            var cliente = _clienteApp.GetById(id);
            _clienteApp.Remove(cliente);

            return RedirectToAction("Index");
        }
    }
}
