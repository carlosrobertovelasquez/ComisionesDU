using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComisionesDU
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        
   
        public Conexion()
        {

            cn = new SqlConnection("Data Source=SRV01;Initial Catalog=DRO_UNI_;Persist Security Info=False;Pwd=DU$an$ivar;User ID=sa");
            //cn = new SqlConnection("Data Source=LAPTOP;Initial Catalog=COAGRO2;User ID=sa;Password=master#$2016");

            if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                
                
           
        }

   

        public void cargarComisiones(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select id,(Clasificacion+'--'+Descripcion) as Casa,  cast(( (Porc_Cobro_Dentro_Periodo*100)) as decimal(16,2)) as Porc_Cobro_Dentro_Periodo   ,cast(( Dias_Cobro_Dentro_Periodo) as decimal(16)) as Dias_Cobro_Dentro_Periodo , cast(( Porc_Cobro_Fuera_Periodo *100) as decimal(16,2)) as Porc_Cobro_Fuera_Periodo ,cast(( Dias_Cobro_Fuera_Periodo) as decimal(16)) as Dias_Cobro_Fuera_Periodo  from DRO_UNI.tabla_comisiones", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

                
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }

        public void guardar( int _id,decimal _PorcCobroDentroPeriodo,decimal _DiasCobroDentroPeriodo,decimal _PorcCobroFueraPeriodo,decimal _DiasCobroFueraPeriodo)
        {
            try
            {

                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }


                string sql = "update DRO_UNI.tabla_comisiones set porc_cobro_dentro_periodo=" + _PorcCobroDentroPeriodo +", dias_cobro_dentro_periodo="+ _DiasCobroDentroPeriodo +", porc_cobro_Fuera_periodo="+_PorcCobroFueraPeriodo +",dias_cobro_Fuera_periodo="+ _DiasCobroFueraPeriodo +"  where ID="+_id +" ";
                


                cmd = new SqlCommand(sql, cn);
               

                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos Actualizados Satisfactoriamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cn.Close();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se Pudo Guardar por siguiente Error" + ex.ToString());
            }
        }

        public void actualizar()
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }


                string sql = "insert into DRO_UNI.tabla_comisiones(Clasificacion ,Descripcion) select CLASIFICACION, DESCRIPCION from CINCOH.CLASIFICACION where CLASIFICACION  not in(select Clasificacion from cincoh.tabla_comisiones ) and AGRUPACION = 3";
                cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
                cn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se Pudo Cargar Informacion" + ex.ToString());
            }
        }

    }
}
