# MassTransit Microservices Project

## Overview

This repository contains a sample microservices project implemented using MassTransit, a distributed application framework for .NET. The project is structured with a publisher-consumer architecture, demonstrating how MassTransit can be used for seamless communication between microservices.

## Project Structure

- **Publisher:** The publisher project is responsible for producing messages and sending them to a message broker (in this case, RabbitMQ). It showcases how to configure MassTransit to publish messages to specific endpoints.

- **Consumer:** The consumer project demonstrates the other side of the microservices architecture. It consumes the messages published by the publisher, processes them, and performs specific actions based on the received messages.

Key Components:
- Configured MassTransit for RabbitMQ message transport
- Added endpoints for message handling
- Implemented basic consumers to process messages
- Established a foundation for building a scalable and distributed microservices system


