using System;

namespace TheatricalPlayersRefactoringKata.Services.PlayType;
public class HistoricalPlayCalculator : IPlayCalculator
{
    private readonly IPlayCalculator _tragedyCalculator = new TragedyPlayCalculator();
    private readonly IPlayCalculator _comedyCalculator = new ComedyPlayCalculator();

    public decimal CalculateAmount(Play play, int audience)
    {
        decimal amountTragedy = _tragedyCalculator.CalculateAmount(play, audience);
        decimal amountComedy = _comedyCalculator.CalculateAmount(play, audience);

        return Math.Round(amountTragedy + amountComedy, 2);
    }

    public int CalculateCredits(Play play, int audience)
    {
        int tragedyCredits = _tragedyCalculator.CalculateCredits(play, audience);
        int comedyCredits = _comedyCalculator.CalculateCredits(play, audience);

        return tragedyCredits;
    }
}