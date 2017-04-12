namespace DiyBeautyRecipes.Models
{
    public class Recipe
    {
        public int RecipeID { get; set; }
        public string Description { get; set; }

        public int BodyPartID { get; set; }
        public virtual BodyPart Category { get; set; }

        public string Ingredients { get; set; }
        public string Instructions { get; set; }

    }
}