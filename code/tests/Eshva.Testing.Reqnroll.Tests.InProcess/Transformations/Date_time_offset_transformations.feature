Feature: Date-time offset transformations

  Scenario: 01. Normal date-time offset value parsing in a step accepting non nullable date-time offset value
    When I use value 31.03.2001 14:13:12 in a step accepting non nullable date-time offset value
    Then parsed date-time offset value should be 31.03.2001 14:13:12 at UTC

  Scenario: 02. Maximum date-time offset value parsing in a step accepting non nullable date-time offset value
    When I use value <max> in a step accepting non nullable date-time offset value
    Then parsed date-time offset value should be maximum date-time value at UTC

  Scenario: 03. Minimum date-time offset value parsing in a step accepting non nullable date-time offset value
    When I use value <min> in a step accepting non nullable date-time offset value
    Then parsed date-time offset value should be minimum date-time value at UTC

  Scenario: 04. Normal date-time offset value parsing in a step accepting nullable date-time offset value
    When I use value 31.03.2001 14:13:12 in a step accepting nullable date-time offset value
    Then parsed date-time offset value should be 31.03.2001 14:13:12 at UTC

  Scenario: 05. Maximum date-time offset value parsing in a step accepting nullable date-time offset value
    When I use value <max> in a step accepting nullable date-time offset value
    Then parsed date-time offset value should be maximum date-time value at UTC

  Scenario: 06. Minimum date-time offset value parsing in a step accepting nullable date-time offset value
    When I use value <min> in a step accepting nullable date-time offset value
    Then parsed date-time offset value should be minimum date-time value at UTC

  Scenario: 07. Null date-time offset value parsing in a step accepting nullable date-time offset value
    When I use value <null> in a step accepting nullable date-time offset value
    Then parsed date-time offset value should be null date-time value
