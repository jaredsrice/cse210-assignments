using System;

public class CategoryManager
{
    private List<string> _categories = new List<string>();

    public CategoryManager()
    {
    }

    public void AddCategory(string category)
    {
        category = NormalizeNaming(category);
        if (!CategoryExists(category))
        {
            _categories.Add(category);
        }
    }

    public bool CategoryExists(string category)
    {
        category = NormalizeNaming(category);
        return _categories.Contains(category);
    }

    private string NormalizeNaming(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
    
            return "";
        
        input = input.Trim().ToLower();
        return char.ToUpper(input[0]) + input.Substring(1);
    }

    public string GetNormalizedNaming(string input)
    {
        return NormalizeNaming(input);
    }
}