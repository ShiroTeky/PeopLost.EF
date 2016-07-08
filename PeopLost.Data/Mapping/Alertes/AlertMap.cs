

using PeopLost.Core.Domain.Alertes;
namespace PeopLost.Data.Mapping.Alertes
{
    public partial class AlertMap : PeopLostEntityTypeConfiguration<Alert>
    {
        public AlertMap()
        {
            this.HasKey(t => t.Id);

            this.Property(t => t.Post);

            this.HasRequired(t => t.Person)
                .WithMany()
                .HasForeignKey(t=>t.PersonId);

            this.Property(t => t.DateAlert);

            this.HasRequired(m => m.Member)
                .WithMany()
                .HasForeignKey(m => m.UserId);

            this.Property(m => m.ConcreteAlert);
          

        }
    }
}