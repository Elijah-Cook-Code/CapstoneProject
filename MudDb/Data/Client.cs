public class Client
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime Date { get; set; } = DateTime.Now;

    public int? A_ChestMeasurement { get; set; }
    public int? B_SeatMeasurement { get; set; }
    public int? C_WaistMeasurement { get; set; }  // ✅ Ensure this exists
    public int? D_TrouserMeasurement { get; set; }
    public int? E_F_HalfBackMeasurement { get; set; }
    public int? G_H_BackNeckToWaistMeasurement { get; set; }
    public int? G_I_SyceDepthMeasurement { get; set; }
    public int? I_L_SleeveLengthOnePieceMeasurement { get; set; }
    public int? E_I_SleeveLengthTwoPieceMeasurement { get; set; }
    public int? N_InsideLegMeasurement { get; set; }
    public int? P_Q_BodyRiseMeasurement { get; set; }
    public int? R_CloseWristMeasurement { get; set; }

    public string Notes { get; set; } = string.Empty;
}
