/*
Delete Middle Node
-------------------
Implement an algorithm to delete a node in the middle of a singly linked list, given only access to that node.

EXAMPLE
Input: the node c from the linked list a->b->c->d->e
Result: nothing is returned, but the new linked list looks like a- >b- >d->e
*/
(function () {
    var LinkedListNode = {
        value: 0,
        next: new LinkedListNode()
    };

    /*
    Time Complexity: 
    Space Complexity: 
    */
    var deleteMiddleNode = function (node) {
        var result = 0;

        console.log(node);

        return result;
    };

    console.log("null:", deleteMiddleNode(null));
    console.log("undefined:", deleteMiddleNode(undefined));
    console.log("0:", deleteMiddleNode(0));
})();