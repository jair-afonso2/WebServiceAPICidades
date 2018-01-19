using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebServicesCidades.Models;


namespace WebServicesCidades.Controllers
{
    //Vamos definir a rota para a requisição do serviço
    [Route("api/[controller]")]
    public class PrimeiraController : Controller
    {
        Cidades cidades = new Cidades();
        DAOCidades dao = new DAOCidades();



        // [HttpGet("{id}")]

        //     public IEnumerable<string> Get(){ ///Enumerable elemento que navega dentro de uma lista[array]
        //              public string Get(int id){
        //                 return new string[]{
        //                     "Curitiba",
        //                     "Porto Alegre",
        //                     "Salvador",
        //                     "Belo Horizonte"
        //         }[id];
        //     }

        //     public IEnumerable<Cidades> Get(int id)
        //     {
        //         return cidades.Listar();
        //     }
        // }

        [HttpGet]
        public IEnumerable<Cidades> Get()
        {
            return dao.Listar();
        }

        [HttpGet("{id}", Name = "CidadeAtual")]
        public Cidades Get(int id)
        {
            return dao.Listar().Where(x => x.Id == id).FirstOrDefault();
        }
      
        [HttpPost]
        public IActionResult Post([FromBody] Cidades cidades)
        {//IAction para ele cadastrar e ja buscar esse dado na lista
            dao.Cadastro(cidades);
            return CreatedAtRoute("CidadeAtual", new { id = cidades.Id }, cidades);
        }

        [HttpPut]
        public IActionResult Editar([FromBody] Cidades cidades)
        {//IAction para ele editar e ja buscar esse dado na lista
           dao.Editar(cidades);  
           return CreatedAtRoute("CidadeAtual", new { id = cidades.Id }, cidades);                    
        }


        [HttpDelete("{id}")]

        public string Apagar(int id)
        {
            return dao.Apagar(id);

        }
    }

}

