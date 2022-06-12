namespace VideoSearchService.Data.Models
{
    public class ActorProfession
    {
        public int ActorId { get; set; }
        public Actor Actor { get; set; }

        public int ProfessionId { get; set; }
        public Profession Profession { get; set; }
    }
}
