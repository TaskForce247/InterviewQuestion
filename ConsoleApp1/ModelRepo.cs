using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ModelRepo //model repo for test
    {
        List<Model> models = new List<Model>();
        Model generic = new Model() { timeFactor = 300, risk = "low" , inconvenience = "high" };
        public ModelRepo()
        {
            Model student1 = new Model() { timeFactor = 500, modelId = "Model1245" , risk = "high", inconvenience = "medium"};
            models.Add(student1);
            Model student2 = new Model() { timeFactor = 2, modelId = "test", risk = "low", inconvenience = "none" };
            models.Add(student2);
        }
        public Model Finder(string modelid)
        {
            Model model;
            var items = models.Where(x => x.modelId == modelid);
            if (items.Any(i => i != null))
            {
                model = items.First();
            }
            else
            { model = generic; }
            return model;
        }
      
    }
}
