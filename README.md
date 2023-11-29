# Bank
My Api design: The system maintains a log of queues for an ending bank.
It includes an entity of type Clerk, Customer and Queue.
For each request to schedule an appointment,
the system checks the first available appointment If no request was sent for a certain time.
If a request has been sent, it will look for the nearest available queue that corresponds to this time,
And if not, return the nearest available queue. Once a turn is found, The system will mark for the time it was caught,
The system will return the free clerk at this time, For the clerk, you will inform that he was caught at this time,
and updates the appointment details for the customer.
