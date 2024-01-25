using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabTask2 : MonoBehaviour
{
    //Public variables that can be changed (amount book sells for and number sold).
    public float coverPrice;
    public int copiesSold;

    //Variable that determine how much the bookstore spent on the books alone.
    float bookstoreDiscount = 0.4f;
    float bookstorePrice; 
    float spentOnBooks;

    //Variables to determine how much was spent on shipping costs.
    int additionalCopiesSold;
    int nonAdditionalCopiesSold = 1;    
    float additionalCopyShipping = 0.75f; 
    int nonAdditionalCopyShipping = 3;   
    float totalShipping;

    //Variables to determine total money spent and earned, leading to profit.
    float totalEarned;
    float wholesaleCost;
    float wholesaleProfit;        
    
    //Run the two calculation functions and display the results in the console.
    void Start()
    {        
        CalculateCosts();
        CalculateEarnings();
        Debug.LogFormat("The bookstore spent ${0} and made ${1} in profit.", wholesaleCost, wholesaleProfit);
    }

    void CalculateCosts()
    {
        //Find the amount spent on shipping by first figuring out the number of additional copies.
        //Once additional copies is known, multiply it by the shipping cost of additional copies.
        //Then, add it to the shipping cost of nonadditional copies to get the total shipping cost.
        additionalCopiesSold = copiesSold - nonAdditionalCopiesSold;
        //Debug.LogFormat("Amount sold: {0}. Number of not additional copies: {1}. Number of additional copies: {2}.", copiesSold, nonAdditionalCopiesSold, additionalCopiesSold);
        totalShipping = (nonAdditionalCopyShipping * nonAdditionalCopiesSold) + (additionalCopyShipping * additionalCopiesSold);
        //Debug.LogFormat("Nonadditional ship price: {0}. Additional copy ship price: {1}. Total spent on shipping: {2}.", nonAdditionalCopyShipping, additionalCopyShipping, totalShipping);
        
        //Find how much the bookstore spent on the books by first calculating their price to obtain the books.
        //Once you know their price, multiply it by how much was sold to figure out the total spent on the books. 
        bookstorePrice = coverPrice - coverPrice * bookstoreDiscount;
        //Debug.LogFormat("Cover price: {0}. Discount: {1}. Bookstore bought for: {2}.", coverPrice, bookstoreDiscount, bookstorePrice);
        spentOnBooks = bookstorePrice * copiesSold;
        //Debug.LogFormat("Total spent on books: {0}.", spentOnBooks);    

        //Finally, calculate the total costs of the bookstore by adding together the total spent on shipping and total spent on books.
        wholesaleCost = spentOnBooks + totalShipping;  
    }

    void CalculateEarnings()
    {
        //Figure out how much the bookstore earned by multiplying how much they sold the books for by the number sold.
        totalEarned = coverPrice * copiesSold;
        //Debug.LogFormat("Total money earned: {0}.", totalEarned);

        //Find the amount of profit earned by the bookstore by subtracting their costs from their earnings.
        wholesaleProfit = totalEarned - wholesaleCost;
    }
}