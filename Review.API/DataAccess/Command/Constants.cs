using System.ComponentModel.DataAnnotations;

namespace Review.API.DataAccess.Command
{
    public partial class ReviewForProductModel
    {
        public enum ScoreValues
        {
            [Display(Name = "0")]
            Zero,
            [Display(Name = "1")]
            One,
            [Display(Name = "2")]
            Two,
            [Display(Name = "3")]
            Three,
            [Display(Name = "4")]
            Four,
            [Display(Name = "5")]
            Five
        }
    }
}
