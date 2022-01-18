using System.Linq;
using System.Windows.Forms;

namespace TechSupport
{
  /// <summary>
  /// This is a helper class that I made to hold extension methods.
  /// </summary> 
  public static class ExtensionMethods
  {
    /// <summary>
    /// Hides the form that called this method, and finds an instance of the form that this is called for.
    ///
    /// If the instance exists, shows it, and if it doesn't then it makes a new one and shows it.
    /// </summary>
    /// <remarks>
    /// I made this extension method because I saw the opportunity of cleaning up repeated code. If
    /// you think that this seems too complex for a beginner at C#, I agree. It is.
    ///
    /// That being said, I write C# professionally during my day job, and have been doing so for 13 years,
    /// so I am not really a beginner.
    ///
    /// If you would prefer me to stick to things that I learned in the class so far I can do that, but honestly
    /// at this point in my career writing code more than once feels unnatural to me.
    /// </remarks>
    /// <typeparam name="T">The type of form that should be shown</typeparam>
    /// <param name="thisForm">The form that is calling this method. Will be hidden.</param>
    /// <returns>the new form that was just shown - in case we need to do anything with it.</returns>
    public static Form HideThisAndShowForm<T>(this Form thisForm) where T : Form, new()
    {
      var otherForm = Application.OpenForms.Cast<Form>()
        .FirstOrDefault(c => c is T) as T;
      if (otherForm == null)
      {
        otherForm = new T();
      }
      otherForm.Show();
      thisForm.Hide();
      return otherForm;
    }
  }
}
