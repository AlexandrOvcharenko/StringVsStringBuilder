// See https://aka.ms/new-console-template for more information
using StringVsStringBuilder;
using static System.Console;

WriteLine("Processing. Please wait...");
Recorder.Start();

int[] largeArrayOfInts = Enumerable.Range(start: 1, count: 10_000).ToArray();
Thread.Sleep(5000);

Recorder.Stop();
