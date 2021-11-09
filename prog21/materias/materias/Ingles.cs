using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace materias
{
    public class Ingles
    {
        
        public DataTable DT { get; set; } = new DataTable();
        
        //public Ingles Nin { get; set; } = new Ingles();
        public Ingles()
            
        {
           
            DT.TableName = "notas de ingles";
            DT.Columns.Add("tp1");
            DT.Columns.Add("tp2");
            DT.Columns.Add("tp3");
            DT.Columns.Add(" primer parcial");
            DT.Columns.Add("tp4");
            DT.Columns.Add("tp5");
            DT.Columns.Add("tp6");
            DT.Columns.Add("segundo parcial ");
            DT.Columns.Add("NOTA FINAL");

            LeerDeArchivo();

        }
        public void LeerDeArchivo()
        {
            if (System.IO.File.Exists("Nin.xml"))
            {
                DT.Clear();
                DT.ReadXml("Nin.xml");
                

            }
        }
        
    }
    
    
	

	}


        



