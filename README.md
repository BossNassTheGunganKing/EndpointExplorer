# Endpoint Explorer
By Timothy Kennedy & Quinton Tracey

### The Problem
Web applications are growing in complexity and understanding their behaviour is critical for developers

### Our Motivation
Existing analysis tools can be blocked, lack interactivity or don’t display information intuitively

### Our Objective

## Basic Spiel 
Reverse engineering is the process of understanding how a system works by carefully examining its structure and behavior. In the internet age, web apps are growing in complexity, and understanding their behaviour is critical for developers. The existing tools we have tested fell short in this respect - some get blocked by websites, others lack interactivity, and many don't present insights in an intuitive way, limiting the useful information we can derive from websites. Our goal is to build a tool that streamlines the reverse engineering process by transforming natural user interactions with a website into key insights about the API.

Introducing Endpoint Explorer, a tool designed to bridge the gap between complexity and usability. It works by parsing recorded interactions with a website into a beginner-friendly visualization that allows for viewing advanced information when needed. The user can modify the recorded interactions and replay them to simulate a user performing those actions on the target web application for testing or debugging behaviours. The customized interactions can be saved or exported into other formats for use among other systems. Now Lets see a quick demo to see it in action.

## Technologies Leveraged
- Main Language, C#
- UI Framework, Uno Platform 
- Main C# libraries leveraged, Newtonsoft.Json​ & Flurl.Http

## Possible Future Extensions
- Hidden Endpoint Discovery, the ability to discover APIs not directly interacted with​
>Could use existing fuzzing techniques​

- Automated interaction collection, further reduction of human effort through automatic collection of HAR file information​
>Train an AI model to interact with websites​

- Enhanced Analytics, get further insights through patterns found​
>Having an interface element to chat with an AI about the extracted information using Retrieval Augmented Generation (RAG)

