# MassTransitDemo

This project demonstrates the use of MassTransit with .NET for building distributed applications using message-based communication.

## Features

- **Message Publishing**: Publish messages to various message brokers.
- **Message Consumption**: Consume messages from queues.

## Getting Started

### Prerequisites

- .NET 6 SDK or later
- Message broker (e.g., RabbitMQ, Azure Service Bus)

### Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/alikrc/MasstransitDemo.git
    cd MasstransitDemo
    ```

2. Restore dependencies:
    ```bash
    dotnet restore
    ```

3. Update the configuration with your message broker settings (e.g., `appsettings.json`).

### Running the Application

1. Build the application:
    ```bash
    dotnet build
    ```

2. Run the application:
    ```bash
    dotnet run
    ```

### Usage

- **Publish a message**: Use the appropriate service to send a message to the configured message broker.
- **Consume a message**: Ensure the consumer service is running to process incoming messages from the queue.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any changes.

## License

This project is licensed under the MIT License.
