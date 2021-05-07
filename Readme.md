This repo is a collection of Architecture and Design Patterns. Currently tehre are four implementations:

#1 CircuitBreaker: improvement of https://docs.microsoft.com/en-us/azure/architecture/patterns/circuit-breaker: it detects failures (by retainig the state of the connection over a series of requests) in a protected function and prevents the application from trying to perform the action that is doomed to fail until it's safe to retry. It keeps an internal state machine.


#2.TemplateMethodDesignPattern: This class implements the Template Pattern (based on Template method) in hypothetical Pipelines As Code

#3.StrategyDesignPattern: This class implements the Strategy design pattern 

#4 State Pattern: allows an object to alter its behaviour when its internal state changes, so it keeps track of the state similar to finite state machines, similar to an implementation of the strategy pattern.

#5 Abstract Factory: family of related factories (i.e.: many)

#6 Factory method: one concrete factory

TODOs: 
#a Some methods have little variations so they can be implemented in teh base class too, e.g.: git clone, publish to an APIm management system, etc

#b Add implementation of delegate System.Action