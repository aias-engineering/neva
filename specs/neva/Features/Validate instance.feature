Feature: Validate instance
  The core funcionality of neva.

  Neva provides a toolset in the following structure:
  
  Tool { name: "NotNull"
  	     execute: x => x != null }
  
  Using the tools defined in the basic toolset, the user of neva may define
  Rulesets for his domain.
  
  Ruleset { target: "Ninja"
  		    memberRules : [ 
  				Rule { member: "Name"
  					   shouldbe: [ "NotNull" ] } ] }
  
  A neva instance initialized with such a ruleset is capable to validate
  if a given Ninja has a name set.
  
  The fully initialized neva instance will validate a provided item and return
  a report.
  
  Report { target = "Ninja"
  		 hasFailed = true
  		 members = [ 
  			Member { name = "Name" 
  					 message = ["NotNull"] } ] }

  
Scenario: Validate name of ninja not null
  Given the ruleset NinjaNameNotNull with the following member rules
         | Member | Should be |
         | Name   | NotNull   |
    And neva is initialized with the following rulesets
         | Ruleset          |
         | NinjaNameNotNull |
  When neva validates the following ninja receiving the report NinjaReport
         | Name |
         |      |
  Then the report NinjaReport should have the following properties
         | Name  | Failed |
         | Ninja | true   |
    And the repoert NinjaReport should contain the following member reports
         | Member | Message |
         | Name   | IsNull  |
