using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PdvApiDapper.Models
{
    public class Pdv
    {


        //Para criar o banco de dados e as tabelas no Sql Server
        //Rodar no Console PM os comandos:
        //Add-Migration FirstMigration
        //Update-Database
        //Para criar o Script de banco de dados
        //Script-Migration
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PdvId { get; set; }
        public double Pagamento { get; set; }
        public double Preco { get; set; }
        public double Troco { get; set; }
        public string NotasMoedas { get; set; }
    }
}
