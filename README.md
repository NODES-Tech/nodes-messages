# NODES Messages

This project contains definitions and documentation for messages used 
in NODES real-time messaging service for external partners. 

## Terminology

### Regulation type

Regulation type is based on production, so that "Up" refers to increased 
production or equivalently decreased consumption. 

Thus up-regulating a battery means withdrawing power from it, 
while up-regulating a consuming device means reducing its power usage. 

### Dispatch

A dispatch happens when a device (an asset / asset portfolio) should be 
operated so that its power consumption/production is changed. 

A typical dispatch event is to turn off a consuming device (e.g. a heater), 
this would then be an up-regulation.

