import pandas as pd
import pprint

df = pd.read_csv('cleanSurvey.csv')
#df.drop_duplicates(keep='first', inplace=True)
print(df.duplicated().sum())
print(df.count())
#df.to_csv('cleanSurvey.csv', sep=',', index=False, encoding='utf-8')

#print(df.loc[df['User_id'].duplicated(keep='first'), 'User_id'].to_string())

#pprint.pprint(df['User_id'])