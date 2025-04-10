public interface ISevenSegmentDisplayState {

    private static ISevenSegmentDisplayState _state;
    public int GetDigit();
    //Get number of current state
    public static extern ISevenSegmentDisplayState GetState();

    public ISevenSegmentDisplayState CountDown(); 
    //Switch to previous state
    public ISevenSegmentDisplayState CountUp();
    //Switch to next state

}