namespace ExBuddy.Interfaces
{
	using Clio.Utilities;

	public interface IInteractWithNpc
	{
		Vector3 Location { get; set; }

		Vector3 InteractLocation { get; set; }

		uint NpcId { get; set; }
	}
}