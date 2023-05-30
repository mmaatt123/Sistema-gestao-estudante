using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sistema_gestao_estudantes
{
    internal class MEU_BD
    {
        private MySqlConnection conexao = new MySqlConnection("datasource=localhost;username=root;password=;database=t4_sga_bd");
    }
}
