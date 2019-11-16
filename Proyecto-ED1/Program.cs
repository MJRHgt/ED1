using System;
using System.IO;
using System.Collections.Generic;

namespace Proyecto_ED1
{
    class Program
    {
        static void Main(string[] args)
        {
			Departamentos departamentos = new Departamentos();

			// departamento, municipio
			departamentos = departamentos.LeerArchivo(0, 0);
        }
    }
}
