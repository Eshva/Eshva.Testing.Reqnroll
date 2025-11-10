Feature: Number transformations

  Scenario: 01. Null signed byte value
    When I use value <null> in a step accepting nullable signed byte value
    Then gotten signed byte value should be null

  Scenario: 02. Minimum signed byte value
    When I use value <min> in a step accepting nullable signed byte value
    Then gotten signed byte value should be minimum value

  Scenario: 03. Maximum signed byte value
    When I use value <max> in a step accepting nullable signed byte value
    Then gotten signed byte value should be maximum value

  Scenario: 04. Null unsigned byte value
    When I use value <null> in a step accepting nullable unsigned byte value
    Then gotten unsigned byte value should be null

  Scenario: 05. Minimum unsigned byte value
    When I use value <min> in a step accepting nullable unsigned byte value
    Then gotten unsigned byte value should be minimum value

  Scenario: 06. Maximum unsigned byte value
    When I use value <max> in a step accepting nullable unsigned byte value
    Then gotten unsigned byte value should be maximum value

  Scenario: 07. Null signed integer value
    When I use value <null> in a step accepting nullable signed integer value
    Then gotten signed integer value should be null

  Scenario: 08. Minimum signed integer value
    When I use value <min> in a step accepting nullable signed integer value
    Then gotten signed integer value should be minimum value

  Scenario: 09. Maximum signed integer value
    When I use value <max> in a step accepting nullable signed integer value
    Then gotten signed integer value should be maximum value

  Scenario: 10. Null unsigned integer value
    When I use value <null> in a step accepting nullable unsigned integer value
    Then gotten unsigned integer value should be null

  Scenario: 11. Minimum unsigned integer value
    When I use value <min> in a step accepting nullable unsigned integer value
    Then gotten unsigned integer value should be minimum value

  Scenario: 12. Maximum unsigned integer value
    When I use value <max> in a step accepting nullable unsigned integer value
    Then gotten unsigned integer value should be maximum value

  Scenario: 13. Null signed short integer value
    When I use value <null> in a step accepting nullable signed short integer value
    Then gotten signed short integer value should be null

  Scenario: 14. Minimum signed short integer value
    When I use value <min> in a step accepting nullable signed short integer value
    Then gotten signed short integer value should be minimum value

  Scenario: 15. Maximum signed short integer value
    When I use value <max> in a step accepting nullable signed short integer value
    Then gotten signed short integer value should be maximum value

  Scenario: 16. Null unsigned short integer value
    When I use value <null> in a step accepting nullable unsigned short integer value
    Then gotten unsigned short integer value should be null

  Scenario: 17. Minimum unsigned short integer value
    When I use value <min> in a step accepting nullable unsigned short integer value
    Then gotten unsigned short integer value should be minimum value

  Scenario: 18. Maximum unsigned short integer value
    When I use value <max> in a step accepting nullable unsigned short integer value
    Then gotten unsigned short integer value should be maximum value

  Scenario: 19. Null signed long integer value
    When I use value <null> in a step accepting nullable signed long integer value
    Then gotten signed long integer value should be null

  Scenario: 20. Minimum signed long integer value
    When I use value <min> in a step accepting nullable signed long integer value
    Then gotten signed long integer value should be minimum value

  Scenario: 21. Maximum signed long integer value
    When I use value <max> in a step accepting nullable signed long integer value
    Then gotten signed long integer value should be maximum value

  Scenario: 22. Null unsigned long integer value
    When I use value <null> in a step accepting nullable unsigned long integer value
    Then gotten unsigned long integer value should be null

  Scenario: 23. Minimum unsigned long integer value
    When I use value <min> in a step accepting nullable unsigned long integer value
    Then gotten unsigned long integer value should be minimum value

  Scenario: 24. Maximum unsigned long integer value
    When I use value <max> in a step accepting nullable unsigned long integer value
    Then gotten unsigned long integer value should be maximum value
