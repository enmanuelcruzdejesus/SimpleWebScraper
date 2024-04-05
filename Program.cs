// See https://aka.ms/new-console-template for more information
using HtmlAgilityPack;

Console.WriteLine("Hello, World!");


// creating the HAP object 
var web = new HtmlWeb(); 

// visiting the target web page 
var document = web.Load("https://fc.dgii.gov.do/ecf/ConsultaTimbreFc?RncEmisor=101155949&ENCF=E320000000681&MontoTotal=1495.00&CodigoSeguridad=Wmm9MP"); 

var tags = document.DocumentNode.QuerySelectorAll("th.text-left");

Console.WriteLine("");

