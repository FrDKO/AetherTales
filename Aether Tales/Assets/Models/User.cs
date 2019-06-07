using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User
{
    Deck deck = new Deck();
    Hand hand = new Hand();
    DropZone dropZone = new DropZone();
    Abyss abyss = new Abyss();

    bool isActive = false;
    public Deck Deck { get => deck; set => deck = value; }
    public Hand Hand { get => hand; set => hand = value; }
    public DropZone DropZone { get => dropZone; set => dropZone = value; }
    public Abyss Abyss { get => abyss; set => abyss = value; }
    public bool IsActive { get => isActive; set => isActive = value; }

    //Strings returned by these are essentially events, when an event occurs, it returns a string
    //Detailing that event. 
    //From Deck
    public string draw()
    {
        Hand.addCard(Deck.draw());
        return "draw";
    }

    public string mill()
    {
        Abyss.addCard(Deck.draw());
        return "mill";
    }

    public string placeTopToDropZone()
    {
        DropZone.addCard(Deck.draw());
        return "deck>dropzone";
    }

//From hand
    public string handToTopDeck(Card card)
    {
        Deck.sendToTop(Hand.discard(card));
        return "hand>deck";
    }
    public string handToBottomDeck(Card card)
    {
        Deck.sendToBottom(Hand.discard(card));
        return "hand>deck";
    }
    public string handToDeck(Card card)
    {
        Deck.addCard(Hand.discard(card));
        Deck.shuffle();
        return "hand>deck";
    }
    public string handToAbyss(Card card)
    {
        Abyss.addCard(Hand.discard(card));
        return "discard";
    }
    public string playCardToDropZone(Card card)
    {
        DropZone.addCard(Hand.playCard(card));
        return "activate";
    }
    public string handToDropZone(Card card)
    {
        DropZone.addCard(Hand.discard(card));
        return "hand>dropzone";
    }
//From Abyss
    public string abyssToTopOfDeck(Card card)
    {
        Deck.sendToTop(Abyss.getCard(card));
        return "abyss>deck";
    }
    public string abyssToBottomOfDeck(Card card)
    {
        Deck.sendToBottom(Abyss.getCard(card));
        return "abyss>deck";
    }

    public string abyssToDeck(Card card)
    {
        Deck.addCard(Abyss.getCard(card));
        Deck.shuffle();
        return "abyss>deck";
    }
    public string abyssToHand(Card card)
    {
        Hand.addCard(Abyss.getCard(card));
        return "abyss>hand";
    }
    public string abyssToDropZone(Card card)
    {
        DropZone.addCard(Abyss.getCard(card));
        return "abyss>dropzone";
    }
//From dropZone
    public string dropZoneToTopOfDeck(Card card)
    {
        Deck.sendToTop(DropZone.getCard(card));
        return "dropzone>deck";
    }
    public string dropZoneToBottomOfDeck(Card card)
    {
        Deck.sendToBottom(DropZone.getCard(card));
        return "dropzone>deck";
    }
    public string dropZoneToDeck(Card card)
    {
        Deck.addCard(DropZone.getCard(card));
        Deck.shuffle();
        return "dropzone>deck";
    }
    public string dropZoneToHand(Card card)
    {
        Hand.addCard(DropZone.getCard(card));
        return "dropzone>hand";
    }
    public string dropZoneToAbyss(Card card)
    {
        Abyss.addCard(DropZone.getCard(card));
        return "dropzone>abyss";
    }
}
