using DataContext;

namespace DigiApi.Models
{
    public class DigimonModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int PreviousEvolution { get; set; }
        public int NextEvolution { get; set; }
        public string? Image { get; set; }

        //agregar los demas elementos cuando se creen las clases


        #region Metodos
        public static List<DigimonModel> GetAll()
        {
            var digimonList = new List<DigimonModel>();
            using (var context = new DigiContext())
            {
                var digimonListEntity = context.Digimons.ToList();
                foreach(var digimonEntity in digimonListEntity)
                {
                    var digimon = new DigimonModel()
                    {
                        Id = digimonEntity.Id,
                        Description = digimonEntity.Description,
                        Name = digimonEntity.Name,
                        PreviousEvolution = digimonEntity.PreviousEvolution,
                        NextEvolution = digimonEntity.NextEvolution,
                        Image = digimonEntity.Image,
                    };
                    digimonList.Add(digimon);
                }
            }


            return digimonList;
        }
        #endregion
    }
}
