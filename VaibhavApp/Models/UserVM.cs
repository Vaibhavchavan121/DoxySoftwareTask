using Microsoft.AspNetCore.Mvc.Rendering;

namespace VaibhavApp.Models
{
    public class UserVM
    {
        public User users { get; set; }

        public IEnumerable<SelectListItem> Country { get; set; }

        public IEnumerable<SelectListItem> State { get; set; }
        public int SelectedCountryId { get; set; }
        public int SelectedStateId { get; set; }
    }
}
