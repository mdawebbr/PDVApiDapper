using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PdvApiDapper.Models;
using Tools = PdvApiDapper.Tools.Tools;

namespace PdvApiDapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PdvController : ControllerBase
    {
        //Persistencia Dapper
        private readonly PdvRepository pdvRepository;

        public PdvController()
        {
            pdvRepository = new PdvRepository();
        }

        [HttpGet]
        public IEnumerable<Pdv> Get() //Ok
        {
            return pdvRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Pdv Get(int id) //Ok
        {
            return pdvRepository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] Pdv pdv) //Ok
        {
            PdvApiDapper.Tools.Tools tools = new PdvApiDapper.Tools.Tools();
            pdv.Troco = pdv.Pagamento - pdv.Preco;
            pdv.NotasMoedas = tools.CalculaNotas(pdv.Pagamento, pdv.Preco);
            if (ModelState.IsValid)
                pdvRepository.Add(pdv);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pdv pdv) //Ok
        {
            PdvApiDapper.Tools.Tools tools = new PdvApiDapper.Tools.Tools();
            pdv.PdvId = id;
            pdv.Troco = pdv.Pagamento - pdv.Preco;
            pdv.NotasMoedas = tools.CalculaNotas(pdv.Pagamento, pdv.Preco);
            if (ModelState.IsValid)
                pdvRepository.Update(pdv);
        }

        [HttpDelete]

        public void Delete(int id)
        {
            pdvRepository.Delete(id);
        }

    }
}