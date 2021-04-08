# Airline-Crew-Scheduler

Cornhusker Airways (CHA) is a small regional airline that flies out of Lincoln, Nebraska; Iowa City, Iowa; Evanston, Illinois; and West Lafayette, Indiana. CHA needs a crew scheduling system to keep track of which employees are on (or are scheduled to be on) each flight. The crew positions are:

- Captain - One of two cockpit positions. The captain must be a qualified pilot for the particular aircraft.
- First Officer - One of two cockpit positions. The first officer must be a qualified pilot or co-pilot for the particular aircraft.
- Flight Attendant - Crew member(s) who are responsible for the safety of passengers in the main cabin.
CHA operates two types of passenger aircraft. GBR-10 aircraft can carry 45 passengers, and NU-150 aircraft can carry 75 passengers. You may assume both types of aircraft have enough range to fly between any two airports that CHA services and, under ideal conditions, will average 500 mph when flying between airports. You do not need to keep track of the maintenance condition of the aircraft.

Each flight must have a flight number, an aircraft (designated by aircraft type and registration number), a captain, a first officer, plus one flight attendant for every fifty passengers (rounded up). A flight has an origin airport, a destination airport, a scheduled takeoff time, an estimated takeoff time, an actual takeoff time, a scheduled touchdown time, an estimated touchdown time, and an actual touchdown time. (For our purposes, a "time" combines the date and the time of date.)

Each airport must have a full standby crew for each type of aircraft, though the standby crew members may be assigned to flights individually rather than as an atomic crew.

Updates to the schedule must be maintained in an electronic log that can be searched by flight, crew member, airport, and/or date range. Each update will generate a unique update number. The update number format must include semantically-significant information that is interpretable by humans, such as including the date of the change and/or the date of the flight as part of the update number. The possible updates are omitted here for brevity and will be provided later.

Any time the schedule is updated, the software must check those constraints. If any of the constraints are violated, the software must alert the user to the violation(s).

Current information about past & future flights and crew assignments must be recoverable after a power outage.

The system may be implemented in text-mode or GUI-mode.
