using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ApplicationConfig
{
    public const string BASE_URL = "https://localhost:7273";
    public static Token  Token { get; set; }
    public static readonly int[] MAX_PAGE = new int[3] { 20, 50, 100 };

}
