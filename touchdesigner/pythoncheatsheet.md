# Python cheat sheet for TouchDesigner

## Operators

| Action                                                                                           | Python command                                                                |
| ------------------------------------------------------------------------------------------------ | ----------------------------------------------------------------------------- |
| Getting an OP's path                                                                             | `op('sphere').path`                                                           |
| Getting an OP's name                                                                             | `op('sphere').name`                                                           |
| Getting an OP's digits                                                                           | `op('sphere').digits`                                                         |
| Querying the value of an OP parameter                                                            | `op('sphere').par.tx.eval()`<br>or when it's a constant `op('sphere').par.tx` |
| Querying a parameter in the same OP                                                              | `me.par.tx`                                                                   |
| Getting [Info CHOP](https://docs.derivative.ca/Info_CHOP) channels from an OP without cooking it | `passive(op('moviein1')).width`                                               |
| Getting an OP's parent                                                                           | `parent()`                                                                    |
| Getting an OP's grand-parent                                                                     | `parent(2)`                                                                   |
| Getting an OP's name                                                                             | `me.name`                                                                     |
| Getting an OP's parent's name                                                                    | `parent().name`                                                               |
| Getting digits of an OP's name from its parameters                                               | `me.digits`                                                                   |
| Getting digits of an OP's parent's name from its parameters                                      | `parent().digits`                                                             |
| Getting an OP's type                                                                             | `# returns an OP object, not a string`<br>`type(op('moviein1'))`              |
| Getting a unique random number each rame                                                         | `tdu.rand(absTime.frame + .1)`                                                |
| Getting a unique random number per numbered operator                                             | `tdu.rand(me.digits + .17)`                                                   |
| Checking for an OP's existence                                                                   | `if op('moviein1'):`<br>or `bool(op('moviein1'))`                             |
| Getting the number of children of a COMP                                                         | `len(op('geo1').children)`                                                    |
| Getting the number of inouts of a multi-input OP                                                 | `len(op('switch1').inputs)`                                                   |
| Getting [Info CHOP](https://docs.derivative.ca/Info_CHOP) channels from an OP, width is a member | `op('moviein1').width`                                                        |
| Conditional "if" in one line of a parameter                                                      | `22 if me.time.frame<100 else 33`<br>or `[33, 22][me.time.frame < 100]`       |
| Convert space separated string to a list                                                         | `tdu.split('space separated string with "two word item"')`                    |
| List comprehension                                                                               | `[c.name for c in root.children]`                                             |
| Conditional list comprehension                                                                   | `[c.name for c in root.children if c.name != 'perform']`                      |
| Test operator type                                                                               | `type(root) == baseCOMP`                                                      |
| Test operator family                                                                             | `isinstance(root, TOP)`                                                       |

## Time/frame

| Action                                    | Python command    |
| ----------------------------------------- | ----------------- |
| Retrieving a node's local frame number    | `me.time.frame`   |
| Retrieving a node's local time in seconds | `me.time.seconds` |
| Retrieving absolute time in frames        | `absTime.frame`   |
| Retrieving absolute time in seconds       | `absTime.seconds` |

## Channels

| Action                                      | Python command                                                                           |
| ------------------------------------------- | ---------------------------------------------------------------------------------------- |
| Evaluate `chan1` at the current frame       | `op('pattern1')['chan1'].eval()`<br>or if in parameter, simply `op('pattern1')['chan1']` |
| Get sample 8 of channel `[chan1]`           | `op('pattern1')['chan1'].eval(8)`                                                        |
| Get the number of CHOP channels             | `op('pattern1').numChans`                                                                |
| Get the CHOP length                         | `op('pattern1').numSamples`                                                              |
| Get the third sample from the first channel | `op('pattern1')[0][2]`                                                                   |
| Get the name of the 2nd channel             | `op('pattern1')[1].name`                                                                 |
| Get the channel index of channel `chan1`    | `op('pattern1')['chan1'].index`                                                          |

## Tables

| Action                                                                                 | Python command                                                                                              |
| -------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| Get a cell value by index                                                              | `op('table1')[2, 3]`                                                                                        |
| Get a cell value by label                                                              | `op('table1')['r1', 'c1']`                                                                                  |
| Get a cell value by row index, col label                                               | `op('table1')[2, 'product']`                                                                                |
| Cast cell to ineger and float                                                          | `int(op('table1')['month', 3])`<br>`float(op('table1')['speed', 4])`                                        |
| Get the number of table rows                                                           | `op('table1').numRows`                                                                                      |
| Get the number of table columns                                                        | `op('table1').numCols`                                                                                      |
| Set a cell value by indeces or labels                                                  | `op('table1')[3, 4] = 'hello`<br>`op('table1')[2, 'answer'] = 'hello`<br>`op('table1')['month', 3] = 'july` |
| Set a cell value by label                                                              | `op('table1')['r1', 'c1'] = 'abc'`                                                                          |
| Copy a table to another table                                                          | `op('table1').copy(op('fromTable'))`                                                                        |
| Append a row to a table                                                                | `op('table1').appendRow(['s1', 's2', num])`                                                                 |
| Append a column to a table                                                             | `op('table1').appendCol(['s1', 's2', num])`                                                                 |
| Access current cell in an [Evaluate DAT](https://docs.derivative.ca/Evaluate_DAT)      | `me.inputCell`                                                                                              |
| Access neighboring cells in an [Evaluate DAT](https://docs.derivative.ca/Evaluate_DAT) | `me.inputCell.offset(1, 2)`                                                                                 |
