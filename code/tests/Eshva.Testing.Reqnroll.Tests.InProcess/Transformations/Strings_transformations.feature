Feature: Strings transformations

  Scenario: 01. Null string value
    When I use value <null> in a step accepting nullable string value
    Then gotten string value should be null

  Scenario: 02. Empty string value
    When I use value <empty> in a step accepting nullable string value
    Then gotten string value should be empty string

  Scenario: 03. White-space string value
    When I use value <empty> in a step accepting nullable string value
    Then gotten string value should be white-space only string

  Scenario: 04. Inline string list as string array with comma as separator
    When I use value ' tag1, tag2,tag3 ' in a step accepting nullable string array
    Then gotten string array should contain the following strings:
      | Item |
      | tag1 |
      | tag2 |
      | tag3 |

  Scenario: 05. Inline string list as string array with semicolon as separator
    When I use value ' tag1; tag2;tag3 ' in a step accepting nullable string array
    Then gotten string array should contain the following strings:
      | Item |
      | tag1 |
      | tag2 |
      | tag3 |

  Scenario: 06. Empty list as string array
    When I use value '<empty>' in a step accepting nullable string array
    Then gotten string array should be empty

  Scenario: 07. Null string array
    When I use value '<null>' in a step accepting nullable string array
    Then gotten string array should be null

  Scenario: 08. Inline string list as string list with comma as separator
    When I use value ' tag1, tag2,tag3 ' in a step accepting nullable string list
    Then gotten string list should contain the following strings:
      | Item |
      | tag1 |
      | tag2 |
      | tag3 |

  Scenario: 09. Inline string list as string list with semicolon as separator
    When I use value ' tag1; tag2;tag3 ' in a step accepting nullable string list
    Then gotten string list should contain the following strings:
      | Item |
      | tag1 |
      | tag2 |
      | tag3 |

  Scenario: 10. Empty list as string list
    When I use value '<empty>' in a step accepting nullable string list
    Then gotten string list should be empty

  Scenario: 11. Null string list
    When I use value '<null>' in a step accepting nullable string list
    Then gotten string list should be null

  Scenario: 12. Inline string list as string readonly list with comma as separator
    When I use value ' tag1, tag2,tag3 ' in a step accepting nullable string readonly list
    Then gotten string readonly list should contain the following strings:
      | Item |
      | tag1 |
      | tag2 |
      | tag3 |

  Scenario: 13. Inline string list as string readonly list with semicolon as separator
    When I use value ' tag1; tag2;tag3 ' in a step accepting nullable string readonly list
    Then gotten string readonly list should contain the following strings:
      | Item |
      | tag1 |
      | tag2 |
      | tag3 |

  Scenario: 14. Empty list as string readonly list
    When I use value '<empty>' in a step accepting nullable string readonly list
    Then gotten string readonly list should be empty

  Scenario: 15. Null string readonly list
    When I use value '<null>' in a step accepting nullable string readonly list
    Then gotten string readonly list should be null
