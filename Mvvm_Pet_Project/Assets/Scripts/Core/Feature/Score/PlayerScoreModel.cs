
namespace Mvvm_Pet_Project.Score.Models
{
    public class PlayerScoreModel
    {
        public int Score { get; private set; }

        public void AddScore(int points)
        {
            Score += points;
        }
    }
}