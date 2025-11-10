Feature: Time span transformations

  Scenario: 01. Normal time span value
    When I use value 10:05:50:34.05 in step accepting nullable time span
    Then gotten time span value should be 10:05:50:34.05

  Scenario: 02. Null time span value
    When I use value <null> in step accepting nullable time span
    Then gotten time span value should be null

  Scenario: 03. Minimal time span value
    When I use value <min> in step accepting nullable time span
    Then gotten time span value should be minimal time span

  Scenario: 04. Miximal time span value
    When I use value <max> in step accepting nullable time span
    Then gotten time span value should be maximal time span
