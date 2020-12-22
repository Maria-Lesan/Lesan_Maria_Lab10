using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Lesan_Maria_Lab10.Models
{
    //Aceasta clasa defineste un model ShopList care va fi folosit pentru a salva fiecare lista de
//cumparaturi in aplicatia noastra
    public class ShopList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    } }
