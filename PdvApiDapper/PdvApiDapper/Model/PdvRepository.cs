using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PdvApiDapper.Models
{
    //Coneção SqlServer para o Dapper
    public class PdvRepository
    {
        private string ConnectionString;

        public PdvRepository() 
        {
            ConnectionString = @"Data Source=SRV2012R2-01;User ID=sa;Password=Eruinem8ii; Initial Catalog=DbPDV; Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public IDbConnection Connection 
        {
            get 
            {
                return new SqlConnection(ConnectionString);
            }
        }
        //Metodos Dapper
        public bool Add(Pdv pdv) 
        {
            try
            {
                object objRetorno = null;
                using (IDbConnection dbConnection = Connection) 
                {
                string  sQuery = @"INSERT INTO PDVS (Pagamento,Preco,Troco,NotasMoedas) VALUES(@Pagamento,@Preco,@Troco,@NotasMoedas)";
                    dbConnection.Open();
                    objRetorno = dbConnection.Execute(sQuery, pdv);
                }

                int intResultado = 0;
                if (objRetorno != null)
                {
                    if (int.TryParse(objRetorno.ToString(), out intResultado))
                        return true;
                }

                return false;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public IEnumerable<Pdv> GetAll()
        {
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                   string sQuery = @"Select * FROM PDVS";
                   dbConnection.Open();
                   return dbConnection.Query<Pdv>(sQuery);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Pdv GetById(int id)
        {
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                string sQuery = @"Select * FROM PDVS Where PDVId = @id";
                dbConnection.Open();
                return dbConnection.Query<Pdv>(sQuery, new { id=id }).FirstOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                object objRetorno = null;
                using (IDbConnection dbConnection = Connection)
                {
                   string sQuery = @"DELETE FROM PDVS Where PDVId = @id";
                   dbConnection.Open();
                   objRetorno = dbConnection.Execute(sQuery, new { id = id });
                }
                int intResultado = 0;
                if (objRetorno != null)
                {
                    if (int.TryParse(objRetorno.ToString(), out intResultado))
                        return true;
                }

                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Update(Pdv pdv)
        {
            try
            {
                object objRetorno = null;
                using (IDbConnection dbConnection = Connection)
                {
                string sQuery = @"UPDATE PDVS SET  Pagamento=@Pagamento,Preco=@Preco,Troco=@Troco,NotasMoedas=@NotasMoedas Where PdvId = @PdvId";
                dbConnection.Open();
                objRetorno = dbConnection.Query(sQuery, pdv);
                }
                int intResultado = 0;
                if (objRetorno != null)
                {
                    if (int.TryParse(objRetorno.ToString(), out intResultado))
                    return true;
                }

                return false;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
