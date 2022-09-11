// See https://aka.ms/new-console-template for more information
using StringVsStringBuilder;
using System.Text;
using static System.Console;

int[] numbers = Enumerable.Range(start: 1, count: 50_000).ToArray();
WriteLine("Using strings with +");

Recorder.Start();
string s = string.Empty;
for (int i = 0; i < numbers.Length; i++) {
	s += numbers[i] + ", ";
}
Recorder.Stop();

WriteLine("Using StringBuilder");
Recorder.Start();
StringBuilder builder = new();
for (int i = 0; i < numbers.Length; i++) {
	builder.Append(numbers[i]);
	builder.Append(", ");
}
Recorder.Stop();
