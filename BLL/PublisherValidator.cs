using HiTechDistributionInc.BLL;
using System;

namespace HiTechDistributionInc.BLL
{
    public class PublisherValidator
    {
        public string Validate(Publisher publisher)
        {
            if (publisher == null)
            {
                throw new ArgumentNullException(nameof(publisher));
            }

            if (string.IsNullOrWhiteSpace(publisher.Name))
            {
                return "Please provide a name";
            }

            return null;
        }
    }
}