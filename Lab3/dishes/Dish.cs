namespace Lab3;

public class Dish
{
    public string Name;
    public string Description;
    public long Price;
    public int Fat;
    public int Protein;
    public int Carbohydrates;
    public int Cholesterol;
    public int Sodium;
    public List<Vitamin> Vitamins;
    public int Calcium;
    public int Iron;
    public int Potasium;
    public int Calories;

    public Dish(string name, string description, long price, NutritionFacts nutritionFacts) 
    {
        Name = name;
        Description = description;
        Price = price;
        Fat = GetFatFromNutritionFacts(nutritionFacts);
        Protein = GetProteinFromNutritionFacts(nutritionFacts);
        Carbohydrates = GetCarbohydratesFromNutritionFacts(nutritionFacts);
        Cholesterol = nutritionFacts.Cholesterol;
        Sodium = nutritionFacts.Sodium;
        Vitamins = nutritionFacts.Vitamins;
        Calcium = nutritionFacts.Calcium;
        Iron = nutritionFacts.Iron;
        Potasium = nutritionFacts.Potasium;
        Calories = CalculateCalories();
    }

    private int GetFatFromNutritionFacts(NutritionFacts nutritionFacts)
    {
        return nutritionFacts.Fat;
    }
    
    private int GetProteinFromNutritionFacts(NutritionFacts nutritionFacts)
    {
        return nutritionFacts.Protein;
    }
    
    private int GetCarbohydratesFromNutritionFacts(NutritionFacts nutritionFacts)
    {
        return nutritionFacts.Carbohydrates;
    }

    private int CalculateCalories()
    {
        return Fat * 9 + Protein * 4 + Carbohydrates * 4;
    }
}


public enum Vitamin
{
    A, B, C, D, E
}

public class NutritionFacts()
{
    public int Fat;
    public int Protein;
    public int Carbohydrates;
    public int Cholesterol;
    public int Sodium;
    public List<Vitamin> Vitamins;
    public int Calcium;
    public int Iron;
    public int Potasium;

    public NutritionFacts(int fat, int protein, int carbohydrates, int cholesterol, int sodium, List<Vitamin> vitamins, int calcium, int iron, int potasium) : this()
    {
        Fat = fat;
        Protein = protein;
        Carbohydrates = carbohydrates;
        Cholesterol = cholesterol;
        Sodium = sodium;
        Vitamins = vitamins;
        Calcium = calcium;
        Iron = iron;
        Potasium = potasium;
    }
}

