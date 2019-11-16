using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Proyecto_ED1
{
    class Departamentos
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Municipio { get; set; }

        public bool valido = false;
        public int Mun;
        public int Dep;
        public int todoDPI;

        //Retorna su valor inicial, numero exacto de 13 carateres, se recibe el string que se pedio con nombre ndpi
        public bool Validacion(string ndpi)
        {

            if (ndpi.Length == 13)
            {
                return valido = true;
            }
            else
            {
                return valido = false;
            }
        }
        //Extrae todos los datos
        public void Convertir(string ndpi)
        {
            string Dep1;
            string Mun1;
            string todoDPI1;

            Dep1 = ndpi.Substring(9,2);
            Mun1 = ndpi.Substring(11,2);
            todoDPI1 = ndpi.Substring(0,13);

            Dep = int.Parse(Dep1);
            Mun = int.Parse(Mun1);
            todoDPI = int.Parse(todoDPI1);
        }
        //departamentos y municipios dentro del archivo "Departamentos.css"
        public Departamentos()
		{
		}

		public Departamentos(int ID, string Nombre, string Municipio)
		{
			this.ID = ID;
			this.Nombre = Nombre;
			this.Municipio = Municipio;
		}

        //Se lee documento de texto, para poder generar una distincion palpable para departamentos y municipios
		public Departamentos LeerArchivo(int Dep, int Mun)
		{
			string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Departamentos.txt";
			Departamentos Aux = new Departamentos();
			string s = "";

			using (StreamReader sr = File.OpenText(Path))
			{
				int NoDep = 0;
				bool Found = false;
				while ((s = sr.ReadLine()) != null && Found == false)
				{
					NoDep++;
					if(NoDep == Dep)
					{
						Found = true;
					}				
				}
			}
			string[] deps = s.Split('|');
			string municipio = deps[Mun];
			string departamento = deps[0];

			Aux.Nombre = departamento;
			Aux.Municipio = municipio;
			Aux.ID = Dep;

			return Aux;
		}
	}
}
