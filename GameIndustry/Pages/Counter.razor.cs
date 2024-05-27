using Microsoft.AspNetCore.Components;

namespace GameIndustry.Pages
{
    public partial class Counter
    {
        [Inject]
        public SingletonService singleton { get; set; }
        [Inject]
        public TransientService transirnt { get; set; }
        [CascadingParameter(Name ="Color")]
        public string Color { get; set; }
        [CascadingParameter(Name ="Size")]
        public string Size { get; set; }
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
            singleton.Value = currentCount;
            transirnt.Value = currentCount;
        }
    }
}
