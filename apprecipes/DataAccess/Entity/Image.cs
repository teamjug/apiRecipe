using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using apprecipes.DataAccess.Generic;

namespace apprecipes.DataAccess.Entity
{
    public class Image : DateGeneric
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid id { get; set; }
        public Guid idRecipe { get; set; }
        public string url { get; set; }
        
        #region parents
        public Recipe ParentRecipe { get; set; }
        #endregion
    }
}
