using System.Collections.Generic;

namespace WebServicesCidades.Models
{
    public class Cidades
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Estado { get; set; }
        public int Habitantes { get; set; }

        // public List<Cidades> Listar()
        // {
        //     return new List<Cidades>(){
        //         new Cidades{Id=10,Nome="Leme",Estado="SP",Habitantes=154},
        //         new Cidades{Id=10,Nome="Suzano",Estado="SP",Habitantes=157},
        //         new Cidades{Id=10,Nome="Porto Alegre",Estado="RS",Habitantes=356},
        //         new Cidades{Id=10,Nome="Curitiba",Estado="PR",Habitantes=555},
        //         new Cidades{Id=10,Nome="Diamantina",Estado="MG",Habitantes=885},
        //     };

        // }
    }
}