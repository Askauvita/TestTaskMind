SELECT PLU.PLU_DESCR, CATEGORY.CATEGORY_DESCR FROM PLU, CATEGORY, PLU_CATEGORY WHERE PLU_CATEGORY.CATEGORY_ID=CATEGORY.CATEGORY_ID AND PLU_CATEGORY.PLU_ID=PLU.PLU_ID
UNION ALL
SELECT PLU.PLU_DESCR, NULL FROM PLU WHERE PLU.PLU_ID NOT IN (SELECT PLU_ID FROM PLU_CATEGORY);