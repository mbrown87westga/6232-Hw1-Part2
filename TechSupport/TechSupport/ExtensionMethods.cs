using System;
using System.Data.SqlClient;
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
    /// <typeparam name="T">The type of form that should be shown</typeparam>
    /// <param name="thisForm">The form that is calling this method. Will be hidden.</param>
    /// <returns>the new form that was just shown - in case we need to do anything with it.</returns>
    public static T HideThisAndShowForm<T>(this Form thisForm) where T : Form, new()
    {
      var otherForm = RetrieveOrCreateForm<T>();
      otherForm.Show();
      thisForm.Hide();
      return otherForm;
    }

    /// <summary>
    /// This keeps us from ever having more than one copy of any given form open. If one exists it returns it, and if one doesn't then it makes a new one.
    /// </summary>
    /// <typeparam name="T">The form that we are finding/opening</typeparam>
    /// <returns>the matching form</returns>
    private static T RetrieveOrCreateForm<T>() where T : Form, new()
    {
      return Application.OpenForms.Cast<Form>()
               .FirstOrDefault(c => c is T) as T ?? new T();
    }

    /// <summary>
    /// I didn't want to have to reinvent the wheel, because I knew that someone had done this already. I found it here:
    /// https://stackoverflow.com/questions/8052753/how-to-parse-nullabledatetime-from-a-sqldatareader/24634677
    /// </summary>
    /// <param name="reader">the reader to that we are reading from</param>
    /// <param name="fieldName">the name of the field</param>
    /// <returns>the nullable date time.</returns>
    public static DateTime? GetNullableDateTime(this SqlDataReader reader, string fieldName)
    {
      int x = reader.GetOrdinal(fieldName);
      return reader.IsDBNull(x) ? (DateTime?)null : reader.GetDateTime(x);
    }
  }
}
