## Interpreter Pattern

The interpreter pattern is a design pattern that is useful when developing domain-specific languages or notations. The pattern allows the grammar for such a notation to be represented in an object-oriented fashion that can easily be extended.

The interpreter design pattern is useful for simple languages where performance is not critical. As the grammar becomes more complex, the number of different expression types, each represented by its own class, can become unwieldy and lead to unmanageable class hierarchies. This can also slow the processing of the expressions. For these reasons, the pattern is considered to be inefficient and is rarely used. However, it should not be discounted for some situations.


* Client. The client class represents the consumer of the interpreter design pattern. Client objects build the tree of expressions that represent the commands to be executed, often with the help of a parser class. The Interpret method of the top item in the tree is then called, passing any context object, to execute all of the commands in the tree.

* Context. The context class is used to store any information that needs to be available to all of the expression objects. If no global context is required this class is unnecessary.

* ExpressionBase. This abstract class is the base class for all expressions. It defines the Interpret method, which must be implemented for each subclass.

* TerminalExpression. Terminal expressions are those that can be interpreted in a single object. These are created as concrete subclasses of the ExpressionBase class.

* NonterminalExpression. Non-terminal expressions are represented using a concrete subclass of ExpressionBase. These expressions are aggregates containing one or more further expressions, each of which may be terminal or non-terminal. When a non-terminal expression class's Interpret method is called, the process of interpretation includes calls to the Interpret method of the expressions it holds.