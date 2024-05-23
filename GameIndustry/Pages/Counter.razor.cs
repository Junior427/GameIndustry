using Microsoft.AspNetCore.Components;

namespace GameIndustry.Pages
{
    public partial class Counter
    {
        [Inject]
        public SingletonService singleton { get; set; }
        [Inject]
        public TransientService transirnt { get; set; }

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
            singleton.Value = currentCount;
            transirnt.Value = currentCount;
        }
    }
}
