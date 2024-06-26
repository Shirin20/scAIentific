# Developer Guide for scAIentific: AI-powered Research Front Analyzer

This document provides a comprehensive guide for developers working on the scAIentific project, detailing architecture, APIs, databases, servers, version control, development environments, code standards, and how to get started with development. It also covers learning new techniques, testing, and plans for future iterations.

## Features

- **File Upload**: Users can upload a word file with size up to 512 MB directly into the AI assistant.
- **Custom AI-Assistant Creation**: Allows users to create a personalized AI assistant. This specialized assistant is proficient in a research field specified by the user.
- **Research Discussion with the AI-Assistant**: Offers the capability to converse with the assistant and discuss the file's content, assisting in the identification of the research front.
- **The AI-Assistant chat history**: The user will get the chat history sent to their mail.

## Architecture and Design

scAIentific's architecture is designed to facilitate efficient analysis of scientific texts, leveraging AI to identify research trends.

![Architecture Overview](AppOverview/arcitecture.png)

## APIs, Databases, Servers, and Services

### APIs

- `/create-assistant`: Endpoint for creating an assistant with a thread, and upload a file to it.
- `/get-assistant`: Endpoint To retrieve the assistant information.
- `/delete-assistant`: Endpoint To delete the assistant and send the chat history to the user mail.
- `/send-message`: Endpoint for real-time communication with the AI-assistant.
- `/chat-history`: Endpoint to retrieve all the old chat messages.
- `/auth/register`: Endpoint to register a new user.
- `/auth/login`: Endpoint to log in.
- `/auth/delete/{username}`: Endpoint to delete a user, its added for testing purposes .

We utilize the OpenAI Assistant API for AI interactions

### databases

- MongoDB Atlas.

### Servers

Cs cloud machine is used to deploy our app .

### Services  

#### ChatGPT Microservice

Our application incorporates the ChatGPT microservice as a core component, responsible for managing communication with the OpenAI Assistant. This microservice acts as an intermediary, ensuring efficient and reliable information transfer between the OpenAI API and our frontend. It is designed to process and serve AI-generated insights, facilitating seamless interaction within the scAIentific platform.

- **Functionality**: The ChatGPT microservice handles requests from the frontend, queries the OpenAI Assistant API for information or analysis, and then formats and returns the response to the user interface. This includes creating an assistant, uploading files, and supporting real-time discussions with the AI assistant.
  
- **Technology Stack**: Developed with C# and .NET.
  
## Version Control Instructions

Version control is managed through Git, with a focus on feature branching and pull requests to ensure code quality and facilitate collaborative development.
The merge request is applied upon consensus approval.

## Development Environments

Developers are encouraged to use Visual Studio or Visual Studio Code, equipped with the .NET SDK, to work on the scAIentific project.

## Code Standards

We adhere to standard coding practices for .NET and C#, with static code analysis tools integrated to maintain code quality. Developers are expected to follow these standards to ensure consistency and readability across the codebase.

## Setting Up the Development Environment

To get the development environment up and running:

1. Clone the repository.
2. Install required dependencies.
3. Follow the setup instructions detailed in the `Getting Started` section of this document.

## Getting Started

### Prerequisites

- .NET core 8.  
- An IDE such as Visual Studio or Visual Studio Code
- Access to the provided AI model or equivalent

### Setup

1. Clone the repository to your local machine.
2. Ensure all required software and dependencies are installed.
3. Navigate to the project directory and restore the required packages:

```shell
dotnet restore
```

4. Start the backend server:

```shell
dotnet run --project Path/To/ChatGPTAPI
```

5. Start the frontend application:

```shell
cd Path/To/Frontend
dotnet run
```

## Usage

- Navigate to the frontend application through your web browser.
- Register a new user, log in, upload your file and decide the research area and then start interacting with your assistant .

## Testing Strategy  

The testing plan: 

Our comprehensive testing strategy is designed to ensure both the technical robustness of the scAIentific platform and the effectiveness of the AI-driven functionalities it offers. It is divided into two main components: User Feedback Testing and Code Testing.

### User Feedback Testing

To refine and enhance the AI assistant's ability to analyze and discuss scientific articles, we are going to rely heavily on the user feedback. This iterative process involves:

- **Pilot User Program**: The main costumer will be given an early access to the scAIentific application to use its features in real-world research scenarios.
- **Feedback Collection**: the costumer will provide detailed feedback on his interactions with the AI assistant, especially regarding the relevance and clarity of its responses and the usability of the interface for uploading documents and creating custom AI assistants.
- **Prompt Improvement**: Based on The costumer feedback, our team will iteratively improve the AI prompts and the underlying logic of the AI assistant to better meet the needs of our users. This includes tuning the AI's response generation to ensure more accurate, relevant, and helpful interactions.

### Code Testing

To ensure the application's reliability and functionality, our development process incorporates both integration tests and end to end tests:

- **Integration Testing**: We are testing all of our backend endpoints with different scenarios to make sure they return the correct status codes. This will help in identifying early bugs in the development cycle.
- **End To End Testing**: In addition to automated tests, manual testing is going to be conducted to ensure that the user interface and user experience meet our quality standards. This will involve realistic user scenarios to test the application's end-to-end capabilities.

### Future Testing Improvements if someone wants to further develop our project

For future iterations, you could introduce:

- **Automated UI Testing**: Implementing automated tests for the user interface to further ensure application reliability and user satisfaction.
- **Performance Testing**: Conducting tests to assess the application's performance under various conditions, ensuring scalability and responsiveness.

## Learning the Project's Technologies

### OpenAI Documentation and Prompt Engineering

Understanding how to interact with the OpenAI API and effectively engineer prompts is crucial for the development of our AI assistant. The following resources offer comprehensive guidance:

- **OpenAI Documentation**: This documentation provides an in-depth look at how to work with the OpenAI Assistant, including setup, API calls, and managing interactions.
  
  [OpenAI Documentation - How It Works](https://platform.openai.com/docs/assistants/how-it-works)

- **OpenAI Prompt Engineering Guide**: A valuable resource for learning how to craft effective prompts to achieve better results from the AI. It outlines strategies and best practices in prompt engineering.
  
  [OpenAI Prompt Engineering Guide](https://platform.openai.com/docs/guides/prompt-engineering/six-strategies-for-getting-better-results)

### Blazor and C# Tutorials

For frontend and backend development, we use Blazor and C#. The following YouTube channel offers comprehensive tutorials ranging from beginner to advanced levels, covering various aspects of working with these technologies:

- **Blazor and C# Tutorials by Tim Corey**: Tim Corey's channel is an excellent resource for learning Blazor and C#, providing detailed video tutorials on a wide range of topics related to .NET development.
  
  [IAmTimCorey on YouTube](https://www.youtube.com/@IAmTimCorey)

## Future Improvements to be made by us our someone else if they wanna further develop what we started

- To be able to upload an excel file.
- Give the user the ability to create more then one assistant.  
- Give the user more options to tune and customize the assistant's personality, characteristics and skills.
