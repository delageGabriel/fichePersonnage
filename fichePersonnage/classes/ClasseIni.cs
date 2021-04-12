using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fichePersonnage
{
    class ClasseIni
    {
        // Attributs
        private IniData data;
        private FileIniDataParser parser;

        // Constructeur
        public ClasseIni(string cheminFichierIni)
        {
            this.CheminFichierIni = cheminFichierIni;
            this.parser = new FileIniDataParser();
        }

        // Accesseur/Mutateur
        public string CheminFichierIni { get; set; }

        public string LireIni(string sectionName, string keyName)
        {
            this.data = this.parser.ReadFile(this.CheminFichierIni);
            string resultat = this.data[sectionName][keyName];
            return resultat;
        }
    }
}
