using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Add class library :

using SqlLibrary;

namespace TP5_SalmaEl
{
    class ModuleDAO : DAO, IDAO<Module>
    {
        public ModuleDAO(string table) : base(table)
        {

        }


        // METHODE CRUD

            // Delete Function
        public int Delete(string conditions)
        {
            return base.delete(conditions);
        }


            //insert function
        public int insert(Module M)
        {
            return base.insert(M.ConverObjectToDictionnary());
        }

            //update Function
        public int update(Module M, string req)
        {
            return base.update(req, M.ConverObjectToDictionnary());
        }


            //Select function
        public ArrayList select(string req)
        {
            List<Dictionary<string, string>> Liste = base.select(req);
            ArrayList Modules = new ArrayList();
            foreach (Dictionary<string, string> dico in Liste)
            {
                Module M = new Module
                {
                    CodeModul = dico["codeModul"],
                    Designation1 = dico["Designation"],
                    Cod_Fil1 = dico["Cod_Fil"],
                    Niveau = dico["niveau"],
                    Semestre1 = dico["Semestre"],
                    Responsable1 = dico["Responsable"],
                    NombreMatieres1 = int.Parse(dico["NombreMatieres"]),

                };
                Modules.Add(M);

            }
            return Modules;
        }


        public ArrayList selectmodules()  
        {
            List<Dictionary<string, string>> R = base.select("");
            ArrayList Modules = new ArrayList();
            foreach (var D in R)
            {

                Modules.Add(D["codeModul"]);

            }
            return Modules;

        }

        public ArrayList selectModulID(string nom)  // pour select ID of professeur of the NAme Selected
        {
            List<Dictionary<string, string>> R = base.select(new RequestCondition("Designation").Equal(nom));
            ArrayList Modul = new ArrayList();
            foreach (var D in R)
            {

                Modul.Add(D["ID"]);

            }
            return Modul;

        }
    }
}
