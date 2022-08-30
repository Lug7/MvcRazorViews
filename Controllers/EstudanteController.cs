using Microsoft.AspNetCore.Mvc;
using MvcRAzorViews.ViewModels;

namespace MvcRAzorViews.Controllers;


public class EstudanteController : Controller 

{
    //private static List<EstudanteViewModel> estudantes  = new List<EstudanteViewModel>();


    private static List<EstudanteViewModel> estudantes  = 
    new List<EstudanteViewModel> {
        new EstudanteViewModel(1,"Tati Comendo" , "Rua A", true),
         new EstudanteViewModel(1,"thomas turbano" , "Rua B", true),
         new EstudanteViewModel(1,"lamborolla" , "Rua C", false),
         new EstudanteViewModel(1,"ticomia" , "Rua D", true)
    };

    public IActionResult Index()
    {
        return View(estudantes);
    }

public IActionResult Show(int id)
{
     return View(estudantes[id-1]);
 }

}